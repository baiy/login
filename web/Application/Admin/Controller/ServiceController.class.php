<?php
namespace Admin\Controller;
class ServiceController extends \Common\Controller\AdminController {
	private $db;
	public function _initialize() {
		parent::_initialize();
		$this->db = D('Service');
	}

	public function index() {
		$lists = $this->db->order('id DESC')->select();
		$this->assign('lists', $lists);
		$this->SEO('服务列表');
		$this->display();
	}

	public function set() {
		if (!IS_POST) {
			$id    = I('get.id', 0, 'intval');
			$lists = $this->db->find($id);
			$this->assign('lists', $lists);
			$this->SEO(empty($lists) ? '添加服务' : '编辑 [' . $lists['title'] . '] 服务');
			$this->display();
		} else {
			try {
				$id = I('post.id', 0, 'intval');
				$this->db->set_service($id);
			} catch (\Exception $e) {
				$this->__Return($e->getMessage());
			}
			$this->__Return('操作成功', array('url' => U('index')), 'success');
		}
	}

	public function del() {
		$id = I('get.id', 0, 'intval');
		$this->db->delete($id);
		$this->__Return('操作成功', '', 'success');
	}

	public function gettpl() {
		$this->__Return('', $this->db->get_fields(I('get.id', 0, 'intval')), 'success');
	}
}