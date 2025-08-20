<?php
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

require 'PHPMailer-master/src/Exception.php';
require 'PHPMailer-master/src/PHPMailer.php';
require 'PHPMailer-master/src/SMTP.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = trim($_POST["name"]);
    $phone = trim($_POST["phone"]);
    $birthdate = trim($_POST["birthdate"]);

    if (empty($name) || empty($phone) || empty($birthdate)) {
        echo "All fields are required.";
        exit;
    }

    // Send email with PHPMailer
    $mail = new PHPMailer(true);
    try {
        //Server settings
        $mail->isSMTP();
        $mail->Host       = 'smtp.yourserver.com'; // Your SMTP server
        $mail->SMTPAuth   = true;
        $mail->Username   = 'you@example.com';     // SMTP username
        $mail->Password   = 'yourpassword';        // SMTP password
        $mail->SMTPSecure = 'tls';
        $mail->Port       = 587;

        //Recipients
        $mail->setFrom('you@example.com', 'Registration Bot');
        $mail->addAddress('your@email.com', 'Your Name');

        // Content
        $mail->isHTML(true);
        $mail->Subject = 'New User Registration';
        $mail->Body    = "Name: $name <br> Phone: $phone <br> Birthdate: $birthdate";

        $mail->send();
        echo "success";
    } catch (Exception $e) {
        echo "Message could not be sent. Mailer Error: {$mail->ErrorInfo}";
    }
} else {
    echo "Invalid request.";
}
?>