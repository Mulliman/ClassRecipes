var gulp = require('gulp');

var sass = require("gulp-sass");
var paths = {
    webroot: "./wwwroot/" /*Set this to your path accordingly*/
};

paths.scss = paths.webroot + "scss/**/*.scss"; /*watches sub folders inside wwwroot/css/ */
gulp.task('sass', function () {
    gulp.src(paths.scss)
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + "css"));
});
gulp.task('watch-sass', function () {
    gulp.watch(paths.scss, ['sass']);
})