# Run Mesh Combine Studio On Build

[Mesh Combine Studio 2](https://assetstore.unity.com/packages/tools/modeling/mesh-combine-studio-2-101956) のCombineをPlay/アセットバンドル時（VRChatならワールドビルド時）に走らせるやつ

あまりちゃんとテストしてないのでいつも正しく動くかは分からないです。

## Install

### OpenUPM

See [OpenUPM page](https://openupm.com/packages/net.narazaka.unity.mesh-combine-studio-on-build/)

### VCC用インストーラーunitypackageによる方法（おすすめ）

https://github.com/Narazaka/MeshCombineStudioOnBuild/releases/latest から `net.narazaka.unity.mesh-combine-studio-on-build-installer.zip` をダウンロードして解凍し、対象のプロジェクトにインポートする。

### VCCによる方法

1. https://vpm.narazaka.net/ から「Add to VCC」ボタンを押してリポジトリをVCCにインストールします。
2. VCCでSettings→Packages→Installed Repositoriesの一覧中で「Narazaka VPM Listing」にチェックが付いていることを確認します。
3. アバタープロジェクトの「Manage Project」から「Run Mesh Combine Studio On Build」をインストールします。

## Usage

`Mesh Combine Studio On Build` コンポーネントをシーン上に配置して、ビルド時にCombineをしたい`Mesh Combiner`（Mesh Combine Studio）を設定する。

## License

[Zlib License](LICENSE.txt)
