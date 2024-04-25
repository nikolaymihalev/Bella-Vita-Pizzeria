function searchForm() {
    var x = document.getElementById("searchForm");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

document.getElementById("searchLink").addEventListener("click", function () {
    var searchTerm = document.getElementById("searchInput").value;
    var url = "/Product/Search?title=" + encodeURIComponent(searchTerm);
    window.location.href = url;
});

