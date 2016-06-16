/// <binding />
// include plug-ins
var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var del = require('del');
var Collections = require('./collections');

var repo = require('gulp-ca-catalyst').gulpCACatalyst;

var config = {
  //Include all js files but exclude any min.js files
  src: ['app/**/*.js', '!app/**/*.min.js'],
  repo: ['repo/**/*-repo.json'],
  dest: {
    repo: 'generated'
  }
}

gulp.task('build.repo', function () {
  return gulp.src(config.repo)
    .pipe(repo({adapterType: 'cs', folders: 'repo', csprojPath: 'CANG2Web.Model.csproj', destPath: config.dest.repo, baseTemplatePath: 'templates/csharp'}))
    .pipe(gulp.dest(config.dest.repo))
  ;
});

//Set a default tasks
gulp.task('default', ['scripts'], function () { });