// Defining an interface for Student
type Gender = "Male" | "Female" | "Other";

interface Student {
    id: number;
    name: string;
    age: number;
    gender: Gender;
    getDetails(): string;
}

// Implementing the Student interface using a class
class CollegeStudent implements Student {
    constructor(
        public id: number,
        public name: string,
        public age: number,
        public gender: Gender
    ) {}

    getDetails(): string {
        return `ID: ${this.id}, Name: ${this.name}, Age: ${this.age}, Gender: ${this.gender}`;
    }
}

// Creating instances of students
const students: Student[] = [
    new CollegeStudent(1, "Alice", 21, "Female"),
    new CollegeStudent(2, "Bob", 22, "Male"),
    new CollegeStudent(3, "Charlie", 23, "Other")
];

// Function to display students in the HTML
function displayStudents(): void {
    const studentList = document.getElementById("studentList");
    if (studentList) {
        studentList.innerHTML = ""; // Clear previous content
        students.forEach(student => {
            const li = document.createElement("li");
            li.textContent = student.getDetails();
            studentList.appendChild(li);
        });
    }
}

// Add event listener to the button
document.getElementById("showStudents")?.addEventListener("click", displayStudents);
