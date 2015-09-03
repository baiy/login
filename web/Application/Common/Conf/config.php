<?php
return array(
	'URL_MODEL'       => 2,
	'STPL_SWITCH_ON'  => TRUE, //简单模版处理开启
	'CTPL_SWITCH_ON'  => TRUE, //自动创建模版文件
	'CTPL_DATA_PATH'  => '__COMMON_PATH__View/ctpl_data.html', //自动创建模版文件模版
	'DEFAULT_FILTER'  => 'i_stripslashes', //I方法过滤
	'LOAD_EXT_CONFIG' => 'db,system', //加载扩展配置文件
	'DATA_CRYPT_KEY'  => '^gL2[9*x^+', //加密密钥
);