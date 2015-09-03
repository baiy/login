## 集成登录

用于实现漫游登录桌面软件,整体分为两个部分,桌面启动插件(C#)和服务端数据存贮部分(PHP)

## 桌面插件

### 链接样式

    [protocol]://[type]/[path](des)/[parameter](des)/attach(des)/

* `protocol` 自定义协议
    * 自定义协议在`start.reg`配置
* `type` 软件类型
* `path` 软件路径
* `parameter` 软件命令行参数
* `attach` 附加信息 该信息会在统计回传中使用

### 配置文件

    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
      <appSettings>
        <add key="decryptionkey" value="111" />
        <add key="statisticsurl" value="http://www.****.com/stat.php" />
      </appSettings>
    </configuration>

* `decryptionkey` 服务端和插件通讯秘钥
* `statisticsurl` 统计回传地址

回传参数

    http://www.****.com/stat.php??attach=[附加信息]&msg=[插件信息]