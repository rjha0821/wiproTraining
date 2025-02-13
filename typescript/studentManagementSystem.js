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
// Function to display student details
function displayStudent(student) {
    console.log(student.getDetails());
}
// Creating instances of students
var student1 = new CollegeStudent(1, "Alice", 21, "Female");
var student2 = new CollegeStudent(2, "Bob", 22, "Male");
var student3 = new CollegeStudent(3, "Charlie", 23, "Other");
// Displaying student details
displayStudent(student1);
displayStudent(student2);
displayStudent(student3);
// Adding a function to count students
function countStudents(students) {
    return students.length;
}
var studentsList = [student1, student2, student3];
console.log("Total Students: ".concat(countStudents(studentsList)));
