/// <binding BeforeBuild='build-css' />
"use strict";

var gulp = require("gulp"),
    sass = require("gulp-sass"); // добавляем модуль sass

var paths = {
    webroot: "./wwwroot/"
};

// регистрируем задачу для конвертации файла scss в css
gulp.task("build-css", function () {
    return gulp.src('./wwwroot/sass/*.scss')
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + '/css'));
});