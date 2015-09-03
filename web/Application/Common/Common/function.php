<?php
/**
 * 返回经addslashes处理过的字符串或数组
 * @param $string 需要处理的字符串或数组
 * @return mixed
 */
function new_addslashes($string) {
	if (!is_array($string)) {
		return addslashes($string);
	}

	foreach ($string as $key => $val) {
		$string[$key] = new_addslashes($val);
	}

	return $string;
}

/**
 * 返回经stripslashes处理过的字符串或数组
 * @param $string 需要处理的字符串或数组
 * @return mixed
 */
function new_stripslashes($string) {
	if (!is_array($string)) {
		return stripslashes($string);
	}

	foreach ($string as $key => $val) {
		$string[$key] = new_stripslashes($val);
	}

	return $string;
}

/**
 * 返回经htmlspecialchars处理过的字符串或数组
 * @param $obj 需要处理的字符串或数组
 * @return mixed
 */
function new_htmlspecialchars($string) {
	if (!is_array($string)) {
		return htmlspecialchars($string);
	}

	foreach ($string as $key => $val) {
		$string[$key] = new_htmlspecial_chars($val);
	}

	return $string;
}

/**
 * I方法过滤 排除MAGIC_QUOTES_GPC干扰
 */
function i_stripslashes($string) {
	return MAGIC_QUOTES_GPC ? new_stripslashes($string) : $string;
}

/**
 * 将字符串转换为数组
 *
 * @param    string  $data   字符串
 * @return   array   返回数组格式，如果，data为空，则返回空数组
 */
function string2array($data) {
	if ($data == '') {
		return array();
	}

	@eval("\$array = $data;");
	return $array;
}
/**
 * 将数组转换为字符串
 *
 * @param    array   $data       数组
 * @param    bool    $isformdata 如果为0，则不使用new_stripslashes处理，可选参数，默认为1
 * @return   string  返回字符串，如果，data为空，则返回空
 */
function array2string($data, $isformdata = 1) {
	if ($data == '') {
		return '';
	}

	if ($isformdata) {
		$data = new_stripslashes($data);
	}

	return addslashes(var_export($data, TRUE));
}

/**
 * 数组键值选择
 */
function array_key($array, $key = '') {
	if (empty($array) || !is_array($array)) {
		return array();
	}
	if (empty($key)) {
		return $array;
	}
	$list = array();
	foreach ($array as $var) {
		$list[$var[$key]] = $var;
	}
	return $list;
}

/**
 * 字符拆分
 * @param  string  $string
 * @param  boolean $empty  过滤为空
 */
function new_explode($string = '', $empty = TRUE, $str = ',') {
	$lists = array();
	if (!empty($string) && is_string($string)) {
		$lists = explode($str, $string);
		foreach ($lists as $key => $var) {
			$var = trim($var);
			if ($empty === TRUE && $var === '') {
				unset($lists[$key]);
			} else {
				$lists[$key] = $var;
			}
		}
	}
	return $lists;
}

/**
 * 数组拼接
 * @param  array  $array
 * @param  模式 $integrity 是否需要前后添加分隔符
 * @param  boolean $empty  过滤为空
 */
function new_implode($array = array(), $integrity = FALSE, $empty = TRUE, $str = ',') {
	$string = '';
	if (!empty($array) && is_array($array)) {
		foreach ($array as $key => $var) {
			$var = trim($var);
			if ($empty === TRUE && $var === '') {
				unset($array[$key]);
			} else {
				$liarraysts[$key] = $var;
			}
		}

		$string = implode($str, $array);

		if ($integrity === TRUE && !empty($string)) {
			$string = $str . $string . $str;
		}
	}
	return $string;
}

/**
 * 删除数组空元素
 */
function del_array_empty($array) {
	if (!is_array($array)) {
		return array();
	}
	foreach ($array as $key => $var) {
		if (empty($var)) {
			unset($array[$key]);
		}
	}
	return $array;
}

/**
 * 字符截取 TODO
 * @param   string $string 原字符
 * @param   int $length 截取长度
 * @param   string $dot 尾部字符
 * @return
 */
function str_cut($string, $length, $dot = '') {
	$strlen = strlen($string);
	if ($strlen <= $length) {
		return $string;
	}

	$string = str_replace(array(' ', '&nbsp;', '&amp;', '&quot;', '&#039;', '&ldquo;', '&rdquo;', '&mdash;', '&lt;', '&gt;', '&middot;', '&hellip;'), array('∵', ' ', '&', '"', "'", '“', '”', '—', '<', '>', '·', '…'), $string);
	$strcut = '';
	$length = intval($length - strlen($dot) - $length / 3);
	$n      = $tn      = $noc      = 0;
	while ($n < strlen($string)) {
		$t = ord($string[$n]);
		if ($t == 9 || $t == 10 || (32 <= $t && $t <= 126)) {
			$tn = 1;
			$n++;
			$noc++;
		} elseif (194 <= $t && $t <= 223) {
			$tn = 2;
			$n += 2;
			$noc += 2;
		} elseif (224 <= $t && $t <= 239) {
			$tn = 3;
			$n += 3;
			$noc += 2;
		} elseif (240 <= $t && $t <= 247) {
			$tn = 4;
			$n += 4;
			$noc += 2;
		} elseif (248 <= $t && $t <= 251) {
			$tn = 5;
			$n += 5;
			$noc += 2;
		} elseif ($t == 252 || $t == 253) {
			$tn = 6;
			$n += 6;
			$noc += 2;
		} else {
			$n++;
		}
		if ($noc >= $length) {
			break;
		}
	}
	if ($noc > $length) {
		$n -= $tn;
	}
	$strcut = substr($string, 0, $n);
	$strcut = str_replace(array('∵', '&', '"', "'", '“', '”', '—', '<', '>', '·', '…'), array(' ', '&amp;', '&quot;', '&#039;', '&ldquo;', '&rdquo;', '&mdash;', '&lt;', '&gt;', '&middot;', '&hellip;'), $strcut);
	return $strcut . $dot;
}

/**
 * 字符串加密、解密函数
 *
 * @param    string  $txt        字符串
 * @param    string  $operation  ENCODE为加密，DECODE为解密，可选参数，默认为ENCODE，
 * @param    string  $key        密钥：数字、字母、下划线
 * @param    string  $expiry     过期时间
 * @return   string
 */
function sys_auth($string, $operation = 'ENCODE', $key = '', $expiry = 0) {
	$ckey_length = 4;
	$key         = !empty($key) ? $key : C('DATA_CRYPT_KEY');
	$keya        = md5(substr($key, 0, 16));
	$keyb        = md5(substr($key, 16, 16));
	$keyc        = $ckey_length ? ($operation == 'DECODE' ? substr($string, 0, $ckey_length) : substr(md5(microtime()), -$ckey_length)) : '';

	$cryptkey   = $keya . md5($keya . $keyc);
	$key_length = strlen($cryptkey);

	$string        = $operation == 'DECODE' ? base64_decode(substr($string, $ckey_length)) : sprintf('%010d', $expiry ? $expiry + time() : 0) . substr(md5($string . $keyb), 0, 16) . $string;
	$string_length = strlen($string);

	$result = '';
	$box    = range(0, 255);

	$rndkey = array();
	for ($i = 0; $i <= 255; $i++) {
		$rndkey[$i] = ord($cryptkey[$i % $key_length]);
	}

	for ($j = $i = 0; $i < 256; $i++) {
		$j       = ($j + $box[$i] + $rndkey[$i]) % 256;
		$tmp     = $box[$i];
		$box[$i] = $box[$j];
		$box[$j] = $tmp;
	}

	for ($a = $j = $i = 0; $i < $string_length; $i++) {
		$a       = ($a + 1) % 256;
		$j       = ($j + $box[$a]) % 256;
		$tmp     = $box[$a];
		$box[$a] = $box[$j];
		$box[$j] = $tmp;
		$result .= chr(ord($string[$i]) ^ ($box[($box[$a] + $box[$j]) % 256]));
	}

	if ($operation == 'DECODE') {
		if ((substr($result, 0, 10) == 0 || substr($result, 0, 10) - time() > 0) && substr($result, 10, 16) == substr(md5(substr($result, 26) . $keyb), 0, 16)) {
			return substr($result, 26);
		} else {
			return '';
		}
	} else {
		return $keyc . str_replace('=', '', base64_encode($result));
	}
}

//数字 字母转换
function alphaID($in, $to_num = false, $pad_up = false, $pass_key = null) {
	$out   = '';
	$index = 'abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ';
	$base  = strlen($index);
	if ($pass_key !== null) {
		for ($n = 0; $n < strlen($index); $n++) {
			$i[] = substr($index, $n, 1);
		}
		$pass_hash = hash('sha256', $pass_key);
		$pass_hash = (strlen($pass_hash) < strlen($index) ? hash('sha512', $pass_key) : $pass_hash);
		for ($n = 0; $n < strlen($index); $n++) {
			$p[] = substr($pass_hash, $n, 1);
		}
		array_multisort($p, SORT_DESC, $i);
		$index = implode($i);
	}
	if ($to_num) {
		$len = strlen($in) - 1;
		for ($t = $len; $t >= 0; $t--) {
			$bcp = bcpow($base, $len - $t);
			$out = $out + strpos($index, substr($in, $t, 1)) * $bcp;
		}
		if (is_numeric($pad_up)) {
			$pad_up--;
			if ($pad_up > 0) {
				$out -= pow($base, $pad_up);
			}
		}
	} else {
		if (is_numeric($pad_up)) {
			$pad_up--;
			if ($pad_up > 0) {
				$in += pow($base, $pad_up);
			}
		}
		for ($t = ($in != 0 ? floor(log($in, $base)) : 0); $t >= 0; $t--) {
			$bcp = bcpow($base, $t);
			$a   = floor($in / $bcp) % $base;
			$out = $out . substr($index, $a, 1);
			$in  = $in - ($a * $bcp);
		}
	}
	return $out;
}

/**
 * 转化 \ 为 /
 *
 * @param    string  $path   路径
 * @return   string  路径
 */
function dir_path($path) {
	$path = str_replace('\\', '/', $path);
	if (substr($path, -1) != '/') {
		$path = $path . '/';
	}

	return $path;
}
/**
 * 创建目录
 *
 * @param    string  $path   路径
 * @param    string  $mode   属性
 * @return   string  如果已经存在则返回true，否则为flase
 */
function dir_create($path, $mode = 0777) {
	if (is_dir($path)) {
		return TRUE;
	}

	$ftp_enable = 0;
	$path       = dir_path($path);
	$temp       = explode('/', $path);
	$cur_dir    = '';
	$max        = count($temp) - 1;
	for ($i = 0; $i < $max; $i++) {
		$cur_dir .= $temp[$i] . '/';
		if (@is_dir($cur_dir)) {
			continue;
		}

		@mkdir($cur_dir, 0777, true);
		@chmod($cur_dir, 0777);
	}
	return is_dir($path);
}

/**
 * 删除目录及目录下面的所有文件
 *
 * @param    string  $dir        路径
 * @return   bool    如果成功则返回 TRUE，失败则返回 FALSE
 */
function dir_delete($dir) {
	$dir = dir_path($dir);
	if (!is_dir($dir)) {
		return FALSE;
	}

	$list = glob($dir . '*');
	foreach ($list as $v) {
		is_dir($v) ? dir_delete($v) : @unlink($v);
	}
	return @rmdir($dir);
}

/**
 *
 * 获取远程内容
 * @param $url 地址
 * @param $timeout 超时时间
 */
function new_file_get_contents($url, $timeout = 30) {
	$stream = stream_context_create(array('http' => array('timeout' => $timeout)));
	return @file_get_contents($url, 0, $stream);
}

/**
 *
 * 写入文件
 * @param $filename 文件地址
 * @param $data 内容
 */
function new_file_put_contents($filename, $data = '') {
	dir_create(pathinfo($filename, PATHINFO_DIRNAME));
	return @file_put_contents($filename, $data);
}

function json2array($obj) {
	$_arr = is_object($obj) ? get_object_vars($obj) : $obj;
	foreach ($_arr as $key => $val) {
		$val       = (is_array($val) || is_object($val)) ? json2array($val) : $val;
		$arr[$key] = $val;
	}
	return $arr;
}
