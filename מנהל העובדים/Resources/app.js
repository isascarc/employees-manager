const about = document.querySelector(".about");
const btns = document.querySelectorAll(".tab-btn");
const articles = document.querySelectorAll(".content");
const myImage = document.querySelector(".about-img")
//const listImages = ["a.jpg", "b.jpg","c.jpg"];

about.addEventListener("click", function (e) {
  const id = e.target.dataset.id;
  if (id) {
    // remove selected from other buttons
    btns.forEach(function (btn) {
      btn.classList.remove("active");
    });
    e.target.classList.add("active");
    // hide other articles
    articles.forEach(function (article) {
      article.classList.remove("active");
    });
    const element = document.getElementById(id);
        myImage.innerHTML= "<img src=\"./" + id +".jpeg\" alt=\"\" />";
element.classList.add("active");
  }
});