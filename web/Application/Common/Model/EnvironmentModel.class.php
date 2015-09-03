<?php
namespace Common\Model;
class EnvironmentModel extends BaseModel {
	public function set_environment($id = 0) {
		$rules = array(
			array('name', 'require', '环境名称必填！'),
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

	public function set_current_environment($id) {
		return cookie('current_environment', $id);
	}

	public function get_current_environment() {
		$id = cookie('current_environment');
		if (!$id) {
			$id = $this->order('id ASC')->getField('id');
			$this->set_current_environment($id);
		}
		return $id;
	}
}