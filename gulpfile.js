const gulp = require('gulp');
const sass = require('gulp-sass');
const cleanCSS = require('gulp-clean-css');

function copyFonts(cb) {
    gulp.src('node_modules/@fortawesome/fontawesome-free/webfonts/*')
        .pipe(gulp.dest('wwwroot/assets/fonts'));
    cb();
}

function sassToCss(cb) {
    gulp.src('Content/css/*.scss')
        .pipe(sass())
        .pipe(cleanCSS({ compatibility: '*' }))
        .pipe(gulp.dest('wwwroot/assets/css'));
    cb();
}

exports.default = gulp.series(copyFonts, sassToCss);