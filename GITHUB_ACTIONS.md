# GitHub Actions 自动构建说明

## 工作流概述

本项目已配置 GitHub Actions 工作流 (`.github/workflows/build-and-release.yml`),实现以下功能:

### 触发条件

1. **推送到主分支** (`main` 或 `master`)
2. **创建版本标签** (格式: `v1.0.0`)
3. **拉取请求** 到主分支
4. **手动触发** (在 GitHub Actions 页面)

### 工作流程

#### 1. 构建任务 (`build`)
- 安装 .NET 10.0 SDK
- 还原 NuGet 包
- 编译项目
- 运行测试(如果有)
- 发布自包含应用到 `publish/` 目录
- 上传构建产物

#### 2. 安装包构建任务 (`build-installer`)
- 下载构建产物
- 安装 Inno Setup
- 创建 Windows 安装包
- 上传安装包

#### 3. 发布任务 (`release`)
- **仅在创建标签时触发**
- 下载所有构建产物
- 创建压缩包
- 自动创建 GitHub Release

## 使用方法

### 日常开发

直接推送到主分支,会自动编译和构建,但不会创建 Release。

```bash
git add .
git commit -m "你的提交信息"
git push
```

### 创建新版本

当需要发布新版本时,创建一个版本标签:

```bash
# 创建标签
git tag v1.0.0

# 推送标签到 GitHub
git push origin v1.0.0
```

或者在 GitHub 网页端创建 Release,会自动生成标签。

### 手动触发

1. 进入 GitHub 仓库页面
2. 点击 "Actions" 选项卡
3. 选择 "Build and Release" 工作流
4. 点击 "Run workflow"
5. 选择分支并点击 "Run workflow"

## 输出文件

### 便携版 (Portable)
- 位置: Actions Artifacts
- 文件名: `LifeReaper-portable-x64.zip`
- 说明: 解压后即可运行,无需安装

### 安装包版 (Setup)
- 位置: Actions Artifacts / GitHub Release
- 文件名: `LifeReaper-Setup-x64.exe`
- 说明: 运行安装向导,安装到系统

## 注意事项

1. **.NET 版本**: 项目使用 .NET 10.0,确保 GitHub Actions 环境支持
2. **Windows 专用**: 由于是 Windows Forms 应用,只能在 Windows 环境构建
3. **Inno Setup**: 自动通过 Chocolatey 安装,无需手动配置
4. **Release 创建**: 只有推送标签时才会自动创建 Release

## 环境变量

可以在工作流顶部修改以下环境变量:

```yaml
env:
  DOTNET_VERSION: '10.0.x'  # .NET SDK 版本
  APP_NAME: "Life Reaper"   # 应用名称
  OUTPUT_DIR: installer/output  # 输出目录
```

## 自定义

如需修改构建流程,编辑 `.github/workflows/build-and-release.yml` 文件。

参考文档: [GitHub Actions 文档](https://docs.github.com/en/actions)
