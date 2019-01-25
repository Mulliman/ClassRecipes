var gulp = require('gulp');
var concat = require('gulp-concat');

var sass = require("gulp-sass");
var paths = {
    webroot: "./wwwroot/",
    common: "./Areas/Common/",
    recipes: "./Areas/Recipes/",
};

paths.baseScss = paths.common + "scss/base.scss";
paths.recipesBaseScss = paths.recipes + "scss/Base/recipe-base.scss";
paths.recipesThemesScss = paths.recipes + "scss/Themes/*.scss";

gulp.task('sass', function () {

    gulp.src(paths.baseScss)
        .pipe(sass())
        .pipe(concat('base.css'))
        .pipe(gulp.dest(paths.webroot + "css"));

    gulp.src(paths.recipesBaseScss)
        .pipe(sass())
        .pipe(concat('recipe-base.css'))
        .pipe(gulp.dest(paths.webroot + "css"));

    gulp.src(paths.recipesThemesScss)
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + "css"));

    
});
gulp.task('watch-sass', function () {
    gulp.watch(paths.scss, ['sass']);
})