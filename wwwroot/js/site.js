window.saveScrollPosition = function () {
sessionStorage.setItem('scrollPos', window.scrollY);
};

window.restoreScrollPosition = function () {
const scrollPos = sessionStorage.getItem('scrollPos');
if (scrollPos) {
window.scrollTo(0, parseInt(scrollPos, 10));
sessionStorage.removeItem('scrollPos');
}
};
window.downloadFileFromText = function (fileName, content) {
    const blob = new Blob([content], { type: 'text/csv;charset=utf-8;' });

    if (window.navigator && window.navigator.msSaveOrOpenBlob) {
        // Support for IE
        window.navigator.msSaveOrOpenBlob(blob, fileName);
        return;
    }

    const link = document.createElement('a');
    const url = URL.createObjectURL(blob);

    link.href = url;
    link.download = fileName;
    document.body.appendChild(link);
    link.click();

    document.body.removeChild(link);
    URL.revokeObjectURL(url);
};
