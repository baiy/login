<?php
namespace Admin\Controller;
class EnvironmentController extends \Common\Controller\AdminController {
	private $db;
	public function _initialize() {
		parent::_initialize();
		$this->db = D('Environment');
	}

	public function index() {
		$lists = $this->db->order('id DESC')->select();
		$this->assign('lists', $lists);
		$this->SEO('环境列表');
		$this->display();
	}

	public function set() {
		if (!IS_POST) {
			$id    = I('get.id', 0, 'intval');
			$lists = $this->db->find($id);
			$this->assign('lists', $lists);
			$this->SEO(empty($lists) ? '添加环境' : '编辑 [' . $lists['name'] . '] 环境');
			$this->display();
		} else {
			try {
				$id = I('post.id', 0, 'intval');
				$this->db->set_environment($id);
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

	public function current() {
		$id = I('get.id', 0, 'intval');
		$this->db->set_current_environment($id);
		$this->__Return('操作成功', '', 'success');
	}

	public function getall() {
		$lists   = $this->db->select();
		$current = $this->db->get_current_environment();
		$this->__Return('', array('lists' => $lists, 'current' => $current), 'success');
	}
}