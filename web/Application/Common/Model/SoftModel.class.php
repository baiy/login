<?php
namespace Common\Model;
class SoftModel extends BaseModel {
	public function set_soft($id = 0) {
		$rules = array(
			array('name', 'require', '软件名称必填！'),
			array('sid', 'require', '服务必填！'),
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

	public function set_soft_path() {
		$softpath_db = D('SoftPath');

		$rules = array(
			array('path', 'require', '路径必填！'),
		);
		if (!$softpath_db->validate($rules)->create()) {
			throw new \Exception($softpath_db->getError());
		}
		$softpath_db->inputtime = NOW_TIME;
		return $softpath_db->add();
	}
	public function del_soft_path($id) {
		return D('SoftPath')->delete(intval($id));
	}

	public function get_path_lists($softid, $eid = '') {
		$where           = array();
		$where['softid'] = $softid;
		if (!empty($eid)) {
			$where['eid'] = $eid;
		}
		return D('SoftPath')->where($where)->select();
	}

	public function get_path($softid, $eid) {
		$lists = $this->get_path_lists($softid, $eid);
		return isset($lists[0]) ? $lists[0] : '';
	}

	public function get_soft($sid, $eid) {
		$where          = [];
		$where['a.sid'] = $sid;
		$where['b.eid'] = array('in', $eid . ',0');
		$lists          = $this->alias('a')
		                       ->where($where)
		                       ->join(C('DB_PREFIX') . 'soft_path b ON a.id = b.softid')
		                       ->field('a.*,b.path,b.id as pathid')
		                       ->order('a.id DESC')
		                       ->select();
		return $lists;
	}
}