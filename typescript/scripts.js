var _a;
// Implementing the Student interface using a class
var CollegeStudent = /** @class */ (function () {
    function CollegeStudent(id, name, age, gender) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
    CollegeStudent.prototype.getDetails = function () {
        return "ID: ".concat(this.id, ", Name: ").concat(this.name, ", Age: ").concat(this.age, ", Gender: ").concat(this.gender);
    };
    return CollegeStudent;
}());
// Creating instances of students
var students = [
    new CollegeStudent(1, "Alice", 21, "Female"),
    new CollegeStudent(2, "Bob", 22, "Male"),
    new CollegeStudent(3, "Charlie", 23, "Other")
];
// Function to display students in the HTML
function displayStudents() {
    var studentList = document.getElementById("studentList");
    if (studentList) {
        studentList.innerHTML = ""; // Clear previous content
        students.forEach(function (student) {
            var li = document.createElement("li");
            li.textContent = student.getDetails();
            studentList.appendChild(li);
        });
    }
}
// Add event listener to the button
(_a = document.getElementById("showStudents")) === null || _a === void 0 ? void 0 : _a.addEventListener("click", displayStudents);
