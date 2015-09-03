<?php
namespace Common\Controller;
//后台登录父类
class AdminController extends \Common\Controller\BaseController {
	public $admin_user;
	public function _initialize() {
		parent::_initialize();
		//检查管理员登录
		$this->check_admin();
		$this->assign('admin_user', $this->admin_user);
	}

	/**
	 * 检查登录
	 */
	private function check_admin() {
		$username = session("admin_username");
		try {
			if (empty($username)) {
				throw new \Exception('系统需要登录！');
			}
			$this->admin_user['username'] = $username;
		} catch (\Exception $e) {
			session("admin_username", NULL);
			$this->__Return($e->getMessage(), array('url' => U('Admin/Auth/index')));
		}
		return;
	}
}