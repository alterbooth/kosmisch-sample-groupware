# kosmisch-sample-groupware-app
## 概要
例えば、あなたは情報システム部に所属していて、社内システムを運用しているとします。
その社内システムは ASP.NET のアプリケーションで、実行環境にオンプレミスのサーバ上で動いているWindows Server 2008 RCを使っています。
サーバハードウェアの更新時期が迫っているので、この機会にOSのサポート終了やメンテナンス性の向上も考え、近々クラウドへ移行したいと考えているとします。

このサンプルでは、そのような課題を解決すべく、後述する機能を持った ASP.NET アプリケーションを Microsoft Azure の PaaS 環境で実行する ASP.NET Core アプリケーションに移行する手順を解説します。

## 対象のアプリケーションについて

簡単な利用者管理と、利用者に対してメール送信が出来るグループウェアのようなアプリです。

- ASP.NET MVCアプリケーション
- ASP.NET Identityでの認証
- ローカルDBにデータを保存
- ログ出力フィルター
- SMTP経由でのメール配信機能

## 解析手順
[「KOSMISCH Monolith を使ってアプリケーションを解析する」](./docs/analyze-application-by-kosmisch-monolith.md)

## 移行手順
[「ASP.NET アプリケーションを ASP.NET Core アプリケーションに移行する」](./docs/migrate-aspnet-to-aspnetcore.md)

## Azureにデプロイする際の参考資料

[「ASP.NET Core アプリケーションを Microsoft Azure にデプロイする際の参考資料」](https://github.com/alterbooth/kosmisch-sample-groupware-app/blob/master/docs/deploy-to-azure.md)

## 実施環境

本サンプルは下記のツールやアカウントを用意した上で実施することを推奨します。

### Visual Studio Code
https://code.visualstudio.com/

### .NET Core 2.1 SDK
https://dotnet.microsoft.com/download/dotnet-core/2.1

### Docker
Windows https://docs.docker.com/docker-for-windows/
Mac https://docs.docker.com/docker-for-mac/

### Git
https://git-scm.com/

### GitHubアカウント
https://github.com/

### SQL Server Express LocalDB
https://docs.microsoft.com/ja-jp/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15

### Azure Storage Emulator
https://docs.microsoft.com/ja-jp/azure/storage/common/storage-use-emulator
