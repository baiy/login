<?php
namespace Common\Behavior;
defined('THINK_PATH') or exit();
//自动创建模版文件
class AutoCreateTemplateBehavior{
    public function run(&$templateFile){
        if(C('CTPL_SWITCH_ON') == TRUE){
            $view = \Think\Think::instance('Think\View');
            $File = $view->parseTemplate($templateFile);
            if(!empty($File) && !is_file($File)){
                $ctpl_data_path = str_replace('__COMMON_PATH__', COMMON_PATH, C('CTPL_DATA_PATH'));
                $dir = pathinfo($File);
                if(!is_dir($dir['dirname'])){
                    mkdir($dir['dirname'],0755,TRUE);
                }
                $content = !empty($ctpl_data_path) && is_file($ctpl_data_path) ? file_get_contents($ctpl_data_path) : '';
                file_put_contents($File, $content);
            }
        }
    }
}