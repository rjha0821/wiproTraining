# Secure and Reliable .NET Application

## **Objective**
Develop a .NET application that demonstrates best practices in **security, reliability, and error handling**. The project includes user authentication, data encryption, and proper error logging.

## **Features**
- Secure **User Authentication** (Registration & Login)
- **Data Encryption** for sensitive information
- **Error Handling** to manage application failures
- **Logging** for monitoring application behavior

---

## **User Stories and Acceptance Criteria**

### **User Story 1: User Authentication**
- Users should be able to register and log in securely.
- Passwords should be **hashed** before storing in the database.
- The system should authenticate users based on **hashed passwords**.

### **User Story 2: Data Encryption**
- **Passwords** and **sensitive data** should be **encrypted**.
- Use **SHA-256** for password hashing.
- Implement **AES encryption** for storing user details.

### **User Story 3: Error Handling**
- Use **try-catch** blocks for exception handling.
- Log errors using **NLog, Serilog, or log4net**.
- Ensure that error messages do not expose sensitive data.

### **User Story 4: Logging**
- Log successful operations and errors.
- Logs should include **timestamps, messages, and stack traces**.
- Save logs to a file or an external logging service.

---

## **Implementation Steps**

### **Step 1: Implement User Authentication**
1. Create a `User` model with properties:
   - `Username`
   - `HashedPassword`
2. Implement **password hashing** using SHA-256.
3. Develop a **login system** that verifies hashed passwords.

### **Step 2: Implement Data Encryption**
1. Use **AES encryption** for encrypting user data.
2. Implement a decryption method.

### **Step 3: Implement Error Handling & Logging**
1. Use **try-catch blocks** for exception handling.
2. Set up a logging framework (**NLog, Serilog, or log4net**).
3. Log errors and important events to a file.

### **Step 4: Write Unit Tests**
1. Test **user authentication** (registration & login).
2. Test **data encryption & decryption**.
3. Simulate **errors** and verify they are **logged correctly**.

---

## **Best Practices**
- Follow **SOLID principles** for maintainable code.
- Use **dependency injection** for better testability.
- Write **unit tests** to validate functionality.

## **Submission Guidelines**
- Ensure **all tests pass** before submission.
- Code should be **well-documented** and **formatted**.
- Submit as a **single project**.

---

## **Conclusion**
This project demonstrates best practices in **secure .NET development** by implementing **authentication, encryption, error handling, and logging**. By following these principles, we ensure a **robust, maintainable, and scalable** application.

---
