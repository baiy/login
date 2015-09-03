<?php
namespace Common\Model;
class TypeModel extends BaseModel {
	public function set_type($id = 0) {
		$rules = array(
			array('title', 'require', '服务名称必填！'),
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

}