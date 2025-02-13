export interface Contact {
    id: number;
    name: string;
    email: string;
    phone: string;
}

export class ContactManager {
    private contacts: Contact[] = [];

    addContact(contact: Contact): void {
        this.contacts.push(contact);
        alert(`Contact added: ${contact.name}`);
        console.log(`Contact added: ${contact.name}`);
        this.displayContacts();
    }

    viewContacts(): Contact[] {
        console.log("Contacts List:", this.contacts);
        return this.contacts;
    }

    modifyContact(id: number, updatedContact: Partial<Contact>): void {
        const contact = this.contacts.find(c => c.id === id);
        if (!contact) {
            alert(`Contact with ID ${id} not found.`);
            console.log(`Contact with ID ${id} not found.`);
            return;
        }
        Object.assign(contact, updatedContact);
        alert(`Contact updated: ${contact.name}`);
        console.log(`Contact updated: ${contact.name}`);
        this.displayContacts();
    }

    deleteContact(id: number): void {
        const index = this.contacts.findIndex(c => c.id === id);
        if (index === -1) {
            console.log(`Contact with ID ${id} not found.`);
            alert(`Contact with ID ${id} not found.`);
            return;
        }
        this.contacts.splice(index, 1);
        console.log(`Contact deleted.`);
        alert(`Contact deleted.`);
        this.displayContacts();
    }

    displayContacts(): void {
        const contactList = document.getElementById("contact-list") as HTMLDivElement;
        contactList.innerHTML = "";
        this.contacts.forEach(contact => {
            const contactItem = document.createElement("div");
            contactItem.innerHTML = `
                <strong>${contact.name}</strong> (${contact.email}, ${contact.phone})
                <button onclick="modifyContact(${contact.id})">Modify</button>
                <button onclick="deleteContact(${contact.id})">Delete</button>
            `;
            contactList.appendChild(contactItem);
        });
    }
}