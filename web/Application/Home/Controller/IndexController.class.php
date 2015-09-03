<?php
namespace Home\Controller;
class IndexController extends \Common\Controller\BaseController {
	public function index() {
		echo U('statistics');
		exit;
		redirect(U(C('admin_url')));
	}

	public function statistics() {

	}
}