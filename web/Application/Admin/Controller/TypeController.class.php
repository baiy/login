<?php
namespace Admin\Controller;
class TypeController extends \Common\Controller\AdminController {
	private $db;
	public function _initialize() {
		parent::_initialize();
		$this->db = D('Type');
	}

	public function index() {
		$lists = $this->db->order('id ASC')->select();
		$this->assign('lists', $lists);
		$this->SEO('分类列表');
		$this->display();
	}

	public function set() {
		if (!IS_POST) {
			$id    = I('get.id', 0, 'intval');
			$lists = $this->db->find($id);
			$this->assign('lists', $lists);
			$this->SEO(empty($lists) ? '添加分类' : '编辑 [' . $lists['title'] . '] 分类');
			$this->display();
		} else {
			try {
				$id = I('post.id', 0, 'intval');
				$this->db->set_type($id);
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
}