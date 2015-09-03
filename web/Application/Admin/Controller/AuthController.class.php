<?php
namespace Admin\Controller;
class AuthController extends \Common\Controller\BaseController {
	public function index() {
		if (IS_POST) {
			try {
				$username = I('post.username', '', 'trim');
				$password = I('post.password', '', 'trim');
				if (empty($username) || empty($password)) {
					throw new \Exception('用户名密码不能为空');
				}
				$admin_user = C('admin_user');
				if (!isset($admin_user[$username]) || md5(md5($password) . $admin_user[$username]['encrypt']) != $admin_user[$username]['password']) {
					throw new \Exception('验证失败');
				}
				session("admin_username", $username);
				$this->__Return('登录成功', array('url' => U(C('admin_url'))), 3);
			} catch (\Exception $e) {
				$this->__Return($e->getMessage(), array('url' => U('Admin/Auth/index')));
			}
		} else {
			$this->SEO('系统登陆');
			$this->display();
		}
	}
	public function logout() {
		session("admin_username", NULL);
		$this->__Return("退出成功", array('url' => U('Admin/Auth/index')));
	}
}