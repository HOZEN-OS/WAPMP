# WAPMP

Windows版 Apache, PHP, MySQL, PostgreSQLの起動ツールです。

XAMPPみたいな感じです。

レジストリを使用せず、インストール不要で開発環境の構築が可能です。



### 使い方

ディレクトリ構成例

WAPMP/
 ├ diskw/ ※
 │ ├ conf/ ※
 │ │ ├ httpd.conf
 │ │ ├ my.ini
 │ │ └ php.ini
 │ ├ EXE/
 │ │　├ Apache24/
 │ │　├ php8/
 │ │　├ mysql/
 │ │　└ share/
 │ ├ tmp/ ※
 │ │ ├ access.log
 │ │ └ error.log
 │ └ www/
 ├ WAPMP.exe
 └ WAPMP.ini

※ 必須のディレクトリです。

diskwディレクトリをwドライブとしてマウントします。※wは変更可能です。

Apacheはconf/httpd.confを読み込みます。

MySQLはconf/my.iniを読み込みます。

初回起動時にディレクトリとWAPMP.iniを作成して終了します。

必要なアプリをEXEディレクトリにコピーし、WAPMP.iniの起動させるアプリのSTARTを1に書き換えてください。

正常に起動するとシステムトレイに緑色の丸いアイコンが表示されます。

ダブルクリックで設定画面が開きます。

右クリックで各アプリの起動メニューが表示されます。

終了させる場合は右クリックし、終了をクリックしてください。