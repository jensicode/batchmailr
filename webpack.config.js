const webpack = require('webpack');
const TerserPlugin = require("terser-webpack-plugin");
const path = require('path');

module.exports = {
    plugins: [
        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery'
        })
    ],
    entry: {
        basescripts: './Content/js/basescripts.js'
    },
    mode: "production",
    optimization: {
        minimize: true,
        minimizer: [
            new TerserPlugin({
                extractComments: false
            })
        ]
    },
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, 'wwwroot/assets/js')
    }
}