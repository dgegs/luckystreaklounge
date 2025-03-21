<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

require 'PHPMailer/PHPMailer.php';
require 'PHPMailer/Exception.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = strip_tags(trim($_POST["name"]));
    $email = filter_var(trim($_POST["email"]), FILTER_SANITIZE_EMAIL);
    $phone = strip_tags(trim($_POST["phone"]));
    $message = trim($_POST["message"]);

    // Validate form inputs
    if (empty($name) || empty($email) || empty($message) || !filter_var($email, FILTER_VALIDATE_EMAIL)) {
        echo "Please fill out all fields correctly.";
        exit;
    }

    // Validate phone number (Optional)
    if (empty($phone) || !preg_match('/^\+?[0-9\s\-\(\)]+$/', $phone)) {
        echo "Please enter a valid phone number.";
        exit;
    }

    $mail = new PHPMailer(true);

    try {
        // Use Sendmail instead of SMTP
        $mail->isSendmail();

        // Set From (use your domain email to avoid spam issues)
        $mail->setFrom('contact@luckystreaklounge.com', 'Lucky Streak Lounge');
        
        // Recipient email (Change to your actual receiving email)
        $mail->addAddress('contact@luckystreaklounge.com'); 
        
        // Reply-To (User email)
        $mail->addReplyTo($email, $name);

        // Email Content
        $mail->isHTML(true);
        $mail->Subject = "New Contact Form Message from $name";
        $mail->Body = "
            <h3>New Contact Message</h3>
            <p><strong>Name:</strong> $name</p>
            <p><strong>Email:</strong> $email</p>
            <p><strong>Phone:</strong>$phone</p>
            <p><strong>Message:</strong></p>
            <p>$message</p>
        ";

        // Send Email
        $mail->send();
        echo "success";
    } catch (Exception $e) {
        echo "Error: {$mail->ErrorInfo}";
    }
} else {
    echo "Invalid request.";
}
?>
