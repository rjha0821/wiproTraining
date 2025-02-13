import { ContactManager } from "./contactManager.js";

const manager = new ContactManager();

(document.getElementById("add-contact-form") as HTMLFormElement).addEventListener("submit", function (event) {
    event.preventDefault();

    const name = (document.getElementById("name") as HTMLInputElement).value;
    const email = (document.getElementById("email") as HTMLInputElement).value;
    const phone = (document.getElementById("phone") as HTMLInputElement).value;

    if (!name || !email || !phone) {
        alert("Please fill all fields.");
        return;
    }

    manager.addContact({ id: Date.now(), name, email, phone });

    // Clear input fields
    (document.getElementById("name") as HTMLInputElement).value = "";
    (document.getElementById("email") as HTMLInputElement).value = "";
    (document.getElementById("phone") as HTMLInputElement).value = "";
});

(window as any).modifyContact = (id: number) => {
    const newName = prompt("Enter new name:");
    const newEmail = prompt("Enter new email:");
    const newPhone = prompt("Enter new phone:");

    if (newName && newEmail && newPhone) {
        manager.modifyContact(id, { name: newName, email: newEmail, phone: newPhone });
    }
};

(window as any).deleteContact = (id: number) => {
    manager.deleteContact(id);
};
