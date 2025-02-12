# Spring Flowers School - Student Portal

## Overview
This is a simple web application for **Spring Flowers School** that allows students to view their **class timetable** online. The application is built using **HTML5, CSS3, Bootstrap**, and **Flexbox** for responsiveness. It is deployed on an **HTTP server** to ensure accessibility.

## Features
- 📌 **Navigation Menu** with a "TimeTable" button.
- 🕒 **Timetable Page** displaying the student class schedule.
- 📱 **Mobile Responsive Design** using **Bootstrap Grid** and **Flexbox**.
- 🚀 **Deployment-Ready** for hosting on a web server.
- 🎨 **Styled with Bootstrap** for a clean and modern UI.

## Technologies Used
- **HTML5** for structuring the pages.
- **CSS3** for styling and responsiveness.
- **Bootstrap 5** for UI enhancements.
- **Flexbox** for layout arrangement.
- **JavaScript (optional)** for future enhancements.
- **Node.js Express (optional)** for local server deployment.

## Installation & Setup

### 1️⃣ Run on Local Machine using Live Server (VS Code)
1. Open the project folder in **VS Code**.
2. Install the **Live Server** extension.
3. Right-click **index.html** → Click **"Open with Live Server"**.
4. Your app will open in the browser.

### 2️⃣ Run using Python HTTP Server
If you have Python installed, run the following command in the project folder:
```sh
python -m http.server 8000
```
Then open **http://localhost:8000** in your browser.

### 3️⃣ Run using Node.js (Express Server)
1. Install **Express**:
   ```sh
   npm install express
   ```
2. Create **server.js**:
   ```javascript
   const express = require('express');
   const app = express();
   const PORT = 3000;

   app.use(express.static(__dirname));

   app.listen(PORT, () => {
       console.log(`Server running at http://localhost:${PORT}`);
   });
   ```
3. Start the server:
   ```sh
   node server.js
   ```
4. Open **http://localhost:3000** in your browser.

## Folder Structure
```
SpringFlowersSchool/
│-- index.html       # Main Page (Home)
│-- timetable.html   # Timetable Page
│-- styles.css       # Stylesheet
│-- server.js        # (Optional) Node.js Server
│-- README.md        # Documentation
```

## Screenshots
### 🏠 Home Page
![Home Page](screenshots/home.png)
### 🕒 Timetable Page
![Timetable Page](screenshots/timetable.png)

## Future Enhancements
- ✅ Add student login authentication.
- ✅ Fetch timetable data from a **backend API**.
- ✅ Add **dark mode** for better accessibility.

## License
This project is **open-source** and can be modified or extended.

---

🎉 **Enjoy your new timetable app!** 🚀

