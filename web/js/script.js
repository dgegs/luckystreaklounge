document.getElementById("contactForm").addEventListener("submit", function(event) {
  event.preventDefault(); // Prevent form from refreshing the page

  let formData = new FormData(this);
  let statusMessage = document.getElementById("statusMessage");

  fetch("contact.php", {
      method: "POST",
      body: formData
  })
  .then(response => response.text())
  .then(data => {
      if (data.trim() === "success") {
          statusMessage.textContent = "Thank you! Your message has been sent.";
          statusMessage.style.color = "green";
          document.getElementById("contactForm").reset();
      } else {
          statusMessage.textContent = data;
          statusMessage.style.color = "red";
      }
  })
  .catch(error => {
    console.error("Error sending message:", error);
    statusMessage.textContent = "Error sending message. Please try again.";
    statusMessage.style.color = "red";
});
});
