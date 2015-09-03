<?php
namespace Admin\Controller;
class ItemController extends \Common\Controller\AdminController {
	private $db;
	public function _initialize() {
		parent::_initialize();
		$this->db = D('Item');
	}

	public function index() {
		$sid     = I('get.sid', 0, 'intval');
		$service = D('Service')->find($sid);
		$where   = array();
		if (!empty($service)) {
			$where['sid'] = $sid;
		}
		$lists = $this->db->where($where)->order('id DESC')->select();

		$this->assign('service', $service);
		$this->assign('lists', $lists);
		$this->assign('servicelists', D('Service')->select());
		$this->SEO('账号列表');
		$this->display();
	}

	public function set() {
		if (!IS_POST) {
			$id    = I('get.id', 0, 'intval');
			$lists = $this->db->find($id);
			$sid   = empty($lists) ? I('get.sid', 0, 'intval') : $lists['sid'];
			if (!empty($lists)) {
				$lists['item_data'] = $this->db->get_item_data($id);
			}
			if (empty($sid)) {
				$this->__Return('请先选择服务');
			}
			$service = D('Service')->find($sid);
			$this->assign('lists', $lists);
			$this->assign('sid', $sid);
			$this->assign('service', $service);
			$this->assign('fields', D('Service')->get_fields($sid));
			$this->assign('typelists', D('Type')->select());
			$this->SEO(empty($lists) ? '添加账号' : '编辑 [' . $lists['name'] . '] 账号');
			$this->display();
		} else {
			try {
				if (isset($_POST['data']['password']) && empty($_POST['data']['password'])) {
					unset($_POST['data']['password']);
				}
				$id = I('post.id', 0, 'intval');
				$this->db->set_item($id);
			} catch (\Exception $e) {
				$this->__Return($e->getMessage());
			}
			$this->__Return('操作成功', array('url' => U('index')), 'success');
		}
	}

	public function del() {
		$id = I('get.id', 0, 'intval');
		$this->db->del($id);
		$this->__Return('操作成功', '', 'success');
	}

	public function run() {
		$ids  = I('get.ids', '', 'trim');
		$ids  = explode('|', $ids);
		$info = [];
		foreach ($ids as $var) {
			$info[$var] = $this->db->get_run_link($var);
		}
		$this->__Return('', $info, 'success');
	}
}