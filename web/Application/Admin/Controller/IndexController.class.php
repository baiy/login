<?php
namespace Admin\Controller;
class IndexController extends \Common\Controller\AdminController {
	public function index() {
		$this->db = D('Item');
		$input    = $where    = array();

		$input['sid'] = I('get.sid', 0, 'intval');
		if (!empty($input['sid'])) {
			$where['sid'] = $input['sid'];
		}

		$input['tid'] = I('get.tid', 0, 'intval');
		if (!empty($input['tid'])) {
			$where['tid'] = $input['tid'];
		}

		$lists = $this->db->where($where)->order('id ASC')->select();
		foreach ($lists as $key => $var) {
			$lists[$key]['lists_fields'] = D('Service')->get_lists_fields($var['sid']);
			$lists[$key]['fields']       = $this->db->get_item_data($var['id']);
		}
		$this->assign('input', $input);
		$this->assign('lists', $lists);
		$this->assign('servicelists', D('Service')->index('id')->select());
		$this->assign('typelists', D('Type')->index('id')->select());
		$this->SEO('集成登录');
		$this->display();
	}
}