
  document.addEventListener("DOMContentLoaded", function () {
    const modalElement = document.getElementById("imageModal");
    const modalImage = document.getElementById("modalImage");
    const imageCaption = document.getElementById("imageCaption");
    const modalTitle = document.getElementById("imageModalLabel");

    if (!modalElement || !modalImage || !imageCaption || !modalTitle) {
      console.error("One or more modal elements not found.");
      return;
    }

    const modal = new bootstrap.Modal(modalElement);

    const imagePaths = [
      "images/frontOld.jpg",
      "images/entranceOldThumb.jpg",
      "images/entranceMain.jpg",
      "images/ceilingOld.jpg",
      "images/ceilingBackView.jpg",
      "images/ceilingOldFront.jpg",
      "images/backSideWall.jpg",
      "images/gamingRoom.jpg",
      "images/coffeeRoom.jpg",
      "images/backHall.jpg",
      "images/paintCeilingFrontMid.jpg",
      "images/ceilingFrontPainted.jpg",
      "images/ceilingMidPainted.jpg",
      "images/ceilingBackPainted.jpg",
      "images/frontDark.jpg",
      "images/griffinPainting.jpg",
      "images/frontFloorPadding.jpg",
      "images/frontFlooring2.jpg",
      "images/finalFloorPiece.jpg",
      "images/frontFloorLookBackFinished.jpg",
      "images/frontViewFinished.jpg",
      "images/carpetPrep.jpg",
      "images/mainWallWrap.jpg",
      "images/veagaWallWrap.jpg",
      "images/carpetInstalled.jpg",
      "images/tables.jpg",
      "images/TheFrontBar.jpg",
      "images/gamesLeft.jpg",
      "images/gamesRight.jpg",
      "images/windowSign.jpg"
    ];

    // Preload images
    imagePaths.forEach((src) => {
      const preloadImg = new Image();
      preloadImg.src = src;
    });

    // Attach modal logic to all visible <img> tags on the page
    document.querySelectorAll("img").forEach((img) => {
      img.style.cursor = "pointer";
      img.addEventListener("click", () => {
        modalImage.src = img.src;
        modalImage.alt = img.alt;
        modalTitle.textContent = img.alt || "Image";
        imageCaption.textContent = img.alt || "";
        modal.show();
      });
    });
  });