<?php
return array(
	'template_filter'=>array('Common\\Behavior\\SimpleTemplateBehavior'),//简单模版处理行为扩展	
	'view_begin'=>array('Common\\Behavior\\AutoCreateTemplateBehavior'),//自动创建模版文件
);