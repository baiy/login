<?php
namespace Common\Controller;
//项目基类
class BaseController extends \Think\Controller{
    public function _initialize(){}
	/**
     * 页面返回
     * @param  string $status   返回状态(stripos) error|success
     * @param  string $info     提示信息
     * @param  string $data     返回数据(跳转链接url 使用array('url'=>'') 跳转时间 使用array('times'=>))
     * @param  string $ajax     是否为ajax 默认为自动判断
     */
    protected function __Return($info ='',$data = '',$status='error',$ajax = 'auto'){
        $ajax = $ajax === 'auto' ? IS_AJAX : $ajax;
        if($ajax === FALSE){
            $jumpUrl = isset($data['url']) ? $data['url'] : '';
            $times = isset($data['times']) && is_numeric($data['times']) ? $data['times'] : FALSE;
            if(stripos('error',$status) !== FALSE){
                $this->error($info,$jumpUrl,$times);
            }
            else{
                $this->success($info,$jumpUrl,$times);
            }
        }
        else{
            $this->ajaxReturn(array('data'=>$data,'info'=>$info,'status'=>$status),'JSON',JSON_UNESCAPED_UNICODE);
        }
        exit;
    }

     /**
     * 页面 标题、关键字、 描述
     */
    public function SEO($title='',$keywords='',$description=''){
        $this->assign('SEO',array('title'=>$title,'keywords'=>$keywords,'description'=>$description));
    }
}