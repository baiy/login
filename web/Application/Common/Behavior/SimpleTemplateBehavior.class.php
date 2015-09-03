<?php
namespace Common\Behavior;
defined('THINK_PATH') or exit();
//简单模版处理行为扩展
class SimpleTemplateBehavior{
    public function run(&$tmplContent){
        if(C('STPL_SWITCH_ON') == TRUE){
            $tmplContent = self::compiler($tmplContent);
        }
    }
    /**
     * 模板编译
     */
    public static function compiler($tmplContent) {
        $tmplContent = preg_replace ( "/\{php\s+(.+)\}/", "<?php \\1?>", $tmplContent );
        //if else
        $tmplContent = preg_replace ( "/\{if\s+(.+?)\}/", "<?php if(\\1) { ?>", $tmplContent );
        $tmplContent = preg_replace ( "/\{else\}/", "<?php } else { ?>", $tmplContent );
        $tmplContent = preg_replace ( "/\{elseif\s+(.+?)\}/", "<?php } elseif (\\1) { ?>", $tmplContent );
        $tmplContent = preg_replace ( "/\{\/if\}/", "<?php } ?>", $tmplContent );
        //for 循环
        $tmplContent = preg_replace("/\{for\s+(.+?)\}/","<?php for(\\1) { ?>",$tmplContent);
        $tmplContent = preg_replace("/\{\/for\}/","<?php } ?>",$tmplContent);
        //++ --
        $tmplContent = preg_replace("/\{\+\+(.+?)\}/","<?php ++\\1; ?>",$tmplContent);
        $tmplContent = preg_replace("/\{\-\-(.+?)\}/","<?php ++\\1; ?>",$tmplContent);
        $tmplContent = preg_replace("/\{(.+?)\+\+\}/","<?php \\1++; ?>",$tmplContent);
        $tmplContent = preg_replace("/\{(.+?)\-\-\}/","<?php \\1--; ?>",$tmplContent);
        //foreach
        $tmplContent = preg_replace ( "/\{loop\s+(\S+)\s+(\S+)\}/", "<?php \$n=1;if(is_array(\\1)) foreach(\\1 AS \\2) { ?>", $tmplContent );
        $tmplContent = preg_replace ( "/\{loop\s+(\S+)\s+(\S+)\s+(\S+)\}/", "<?php \$n=1; if(is_array(\\1)) foreach(\\1 AS \\2 => \\3) { ?>", $tmplContent );
        $tmplContent = preg_replace ( "/\{\/loop\}/", "<?php \$n++;}unset(\$n); ?>", $tmplContent );
        return $tmplContent;
    }
}