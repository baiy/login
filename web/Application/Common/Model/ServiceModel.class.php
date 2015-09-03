<?php
namespace Common\Model;
class ServiceModel extends BaseModel {
	public function set_service($id = 0) {
		$rules = array(
			array('title', 'require', '服务名称必填！'),
			array('protocol', 'require', '服务协议必填！'),
		);
		if (!$this->validate($rules)->create()) {
			throw new \Exception($this->getError());
		}
		if (empty($id)) {
			$this->inputtime = NOW_TIME;
			return $this->add();
		}
		return $this->where(['id' => $id])->save();
	}

	public function get_fields($id) {
		static $info_lists;
		if (!isset($info_lists[$id])) {
			$fields = $this->where(array('id' => $id))->getField('fields');
			$fields = explode("\n", $fields);
			$info   = [];
			foreach ($fields as $var) {
				$var = trim($var);
				if (!empty($var)) {
					$var           = explode('|', $var);
					$info[$var[0]] = [
						'field'   => $var[0],
						'name'    => $var[1],
						'default' => !isset($var[2]) ? '' : $var[2],
					];
				}
			}
			$info_lists[$id] = $info;
		}
		return $info_lists[$id];
	}

	public function get_lists_fields($id) {
		static $info_lists;
		if (!isset($info_lists[$id])) {
			$lists_fields = $this->where(array('id' => $id))->getField('lists_fields');
			$lists_fields = explode('|', $lists_fields);
			$fields       = $this->get_fields($id);
			$info         = array();
			foreach ($lists_fields as $var) {
				$var = trim($var);
				if (!empty($var)) {
					$info[$var] = $fields[$var]['name'];
				}
			}
			$info_lists[$id] = $info;
		}
		return $info_lists[$id];
	}
}