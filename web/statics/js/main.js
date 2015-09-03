function del_confirm(url,text) {
    text = text ? text : "删除";
    if(confirm("确定要"+text+"吗?")==true){
        window.location.href= url;
    }
}