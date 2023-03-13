/** @type {import('tailwindcss').Config} */
module.exports = {
    purge: {
        enabled: false, content: ["./Areas/Identity/**/*.cshtml", "./Views/**/*.cshtml"]
    }, theme: {
        extend: {},
    }, variants: {
        extend: {},
    }, plugins: [],
}
