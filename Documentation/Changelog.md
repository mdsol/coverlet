# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Release date 2020-01-03
### Packages  
coverlet.msbuild 2.8.0  
coverlet.console 1.7.0  
coverlet.collector 1.2.0

### Added
-Add log to tracker [#553](https://github.com/tonerdo/coverlet/pull/553)  
-Exclude by assembly level System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage [#589](https://github.com/tonerdo/coverlet/pull/589)  
-Allow coverlet integration with other MSBuild test strategies[#615](https://github.com/tonerdo/coverlet/pull/615) by https://github.com/sharwell  

### Fixed

-Fix and simplify async coverage [#549](https://github.com/tonerdo/coverlet/pull/549)  
-Improve lambda scenario coverage [#583](https://github.com/tonerdo/coverlet/pull/583)  
-Mitigate issue in case of failure in assembly loading by cecil [#625](https://github.com/tonerdo/coverlet/pull/625)  
-Fix ConfigureAwait state machine generated branches [#634](https://github.com/tonerdo/coverlet/pull/634)  
-Fix coverage overwritten if the project has multiple target frameworks [#636](https://github.com/tonerdo/coverlet/issues/177)  
-Fix cobertura Jenkins reporter + source link support [#614](https://github.com/tonerdo/coverlet/pull/614) by https://github.com/daveMueller  
-Fix pdb file locking during instrumentation [#656](https://github.com/tonerdo/coverlet/pull/656)


### Improvements

-Improve exception message for unsupported runtime [#569](https://github.com/tonerdo/
coverlet/pull/569) by https://github.com/daveMueller  
-Improve cobertura absolute/relative path report generation [#661](https://github.com/tonerdo/coverlet/pull/661) by https://github.com/daveMueller

## Release date 2019-09-23
### Packages  
coverlet.msbuild 2.7.0  
coverlet.console 1.6.0  
coverlet.collector 1.1.0

### Added
-Output multiple formats for vstest integration [#533](https://github.com/tonerdo/coverlet/pull/533) by https://github.com/daveMueller  
-Different exit codes to indicate particular failures [#412](https://github.com/tonerdo/coverlet/pull/412) by https://github.com/sasivishnu


### Changed

-Skip instrumentation of module with embedded ppbd without local sources [#510](https://github.com/tonerdo/coverlet/pull/510), with this today xunit will be skipped in automatic way.

### Fixed

-Fix exclude by files [#524](https://github.com/tonerdo/coverlet/pull/524)  
-Changed to calculate based on the average coverage of the module [#479](https://github.com/tonerdo/coverlet/pull/479) by https://github.com/dlplenin  
-Fix property attribute detection [#477](https://github.com/tonerdo/coverlet/pull/477) by https://github.com/amweiss  
-Fix instrumentation serialization bug [#458](https://github.com/tonerdo/coverlet/pull/458)  
-Fix culture for cobertura xml report [#464](https://github.com/tonerdo/coverlet/pull/464)

