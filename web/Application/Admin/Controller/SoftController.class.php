<?php
namespace Admin\Controller;
class SoftController extends \Common\Controller\AdminController {
	private $db;
	public function _initialize() {
		parent::_initialize();
		$this->db = D('Soft');
	}

	public function index() {
		$lists = $this->db->alias('a')->join('__SERVICE__ b ON a.sid = b.id')->field('a.*,b.title as servicename')->order('a.id DESC')->select();
		$this->assign('lists', $lists);
		$this->SEO('软件列表');
		$this->display();
	}

	public function set() {
		if (!IS_POST) {
			$id    = I('get.id', 0, 'intval');
			$lists = $this->db->find($id);
			$this->assign('servicelists', D('service')->select());

			$this->assign('lists', $lists);
			$this->SEO(empty($lists) ? '添加软件' : '编辑 [' . $lists['name'] . '] 软件');
			$this->display();
		} else {
			try {
				$id = I('post.id', 0, 'intval');
				$this->db->set_soft($id);
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

	public function path() {
		if (!IS_POST) {
			$id    = I('get.id', 0, 'intval');
			$soft  = $this->db->find($id);
			$lists = $this->db->get_path_lists($id);
			$this->assign('lists', $lists);
			$this->assign('environmentlists', D('Environment')->index('id')->select());
			$this->assign('soft', $soft);
			$this->SEO('软件路径[' . $soft['name'] . ']');
			$this->display();
		} else {
			$this->db->set_soft_path();
			$this->__Return('操作成功', '', 'success');
		}
	}

	public function pathdel() {
		$id = I('get.id', 0, 'intval');
		$this->db->del_soft_path($id);
		$this->__Return('操作成功', '', 'success');
	}
}