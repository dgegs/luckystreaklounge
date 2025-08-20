window.addEventListener("DOMContentLoaded", function () {
  // Show modal once per visitor
  if (!localStorage.getItem("modalShown")) {
    var myModalEl = document.getElementById('myModal');
    var myModal = new bootstrap.Modal(myModalEl);
    myModal.show();
    localStorage.setItem("modalShown", "true");
  }

  // Form submission handling
  const contactForm = document.getElementById("contactForm");
  if (contactForm) {
    contactForm.addEventListener("submit", function (event) {
      event.preventDefault();

      const formData = new FormData(this);
      const statusMessage = document.getElementById("statusMessage");

      fetch("register.php", {
        method: "POST",
        body: formData
      })
      .then(response => response.text())
      .then(data => {
        if (data.trim() === "success") {
          statusMessage.textContent = "Thank you! You have been registered.";
          statusMessage.style.color = "green";
          contactForm.reset();
          // Hide modal after successful registration
          const myModalInstance = bootstrap.Modal.getInstance(document.getElementById('myModal'));
          if (myModalInstance) myModalInstance.hide();
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
  }
});
