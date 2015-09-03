<?php
header("Content-type: text/html; charset=utf-8");
define('SYSTEM_PATH', dirname(__FILE__) . DIRECTORY_SEPARATOR);
define('__WEB_PATH__', '/');
define('APP_DEBUG', TRUE);
define('APP_PATH', SYSTEM_PATH . 'Application/');
define('RUNTIME_PATH', SYSTEM_PATH . 'cache/');
require SYSTEM_PATH . 'ThinkPHP/ThinkPHP.php';