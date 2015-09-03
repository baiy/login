<?php
namespace Common\Model;
class ItemModel extends BaseModel {
	public function set_item($id) {
		$rules = array(
			array('sid', 'require', '服务必填'),
			array('name', 'require', '名称必填！'),
		);
		if (!$this->validate($rules)->create()) {
			throw new \Exception($this->getError());
		}

		if (empty($id)) {
			$this->inputtime = NOW_TIME;
			$id              = $this->add();
		} else {
			$this->where(['id' => $id])->save();
		}
		$this->set_item_data($id);
		return true;
	}

	public function del_item($id) {
		$this->delete($id);
		D('ItemData')->where(array('iid' => $id))->delete();
		return;
	}

	public function set_item_data($iid) {
		$des  = new \Common\ORG\DES(C('DATA_CRYPT_KEY'));
		$info = array();
		$data = I('post.data');

		$old              = $this->get_item_data($iid, true);
		$data['password'] = empty($data['password']) ? $old['password'] : $data['password'];

		foreach ($data as $key => $var) {
			$var    = $des->encrypt($var);
			$info[] = array('iid' => $iid, 'fieldname' => trim($key), 'value' => trim($var));
		}
		if (!empty($info) && $iid) {
			D('ItemData')->where(array('iid' => $iid))->delete();
			D('ItemData')->addAll($info);
		}
		return;
	}

	public function get_item_data($id, $decrypt = false) {
		$des          = new \Common\ORG\DES(C('DATA_CRYPT_KEY'));
		$item_data_db = D('ItemData');
		$lists        = $item_data_db->where(array('iid' => $id))->select();
		$info         = array();
		foreach ($lists as $var) {
			$var['value']            = empty($var['value']) ? '' : $des->decrypt($var['value']);
			$info[$var['fieldname']] = $var['fieldname'] == "password" && $decrypt == false ? '' : $var['value']; //password 不显示
		}
		return $info;
	}
	//
	public function get_run_link($id) {
		static $des;
		$des = empty($des) ? new \Common\ORG\DES(C('API_DATA_CRYPT_KEY')) : $des;

		$item = $this->find($id);

		$item_data = $this->get_item_data($id, true);

		$service_db = D('Service');
		$service    = $service_db->find($item['sid']);

		$item_data_field = array_keys($item_data);
		foreach ($item_data_field as $key => $var) {
			$item_data_field[$key] = '{' . $var . '}';
		}
		$item_data_value = array_values($item_data);

		$service_db = D('Service');
		$service    = $service_db->find($item['sid']);

		$environment_db = D('Environment');
		$eid            = $environment_db->get_current_environment();

		$link                        = [];
		$link_tpl                    = '[protocol]://[type]/[path](des)/[parameter](des)/[attach](des)/';
		$replace['[protocol]']       = C('API_PROTOCOL');
		$replace['[type]']           = $service['protocol'];
		$replace['[path](des)']      = '';
		$replace['[parameter](des)'] = '';
		$replace['[attach](des)']    = '';

		$soft = D('Soft')->get_soft($item['sid'], $eid);
		foreach ($soft as $var) {
			$replace['[parameter](des)'] = $des->encrypt(str_replace($item_data_field, $item_data_value, $var['tpl']));
			$replace['[path](des)']      = $des->encrypt($var['path']);
			$replace['[attach](des)']    = $des->encrypt('pathid-' . $var['pathid'] . ',item-' . $item['id'] . ',user-' . session("admin_username"));
			$link[]                      = array(
				'name' => $var['name'],
				'link' => str_replace(array_keys($replace), array_values($replace), $link_tpl),
			);
		}
		return $link;
	}
}