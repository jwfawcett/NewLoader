// Function to force download a file
function autoDownloadFile(fileUrl, fileName) {
    const link = document.createElement('a');
    link.href = fileUrl;
    link.download = fileName; // Suggests a filename to the browser
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

// Automatically trigger on page load
window.addEventListener('DOMContentLoaded', () => {
    autoDownloadFile('https://example.com', 'report.pdf');
});
