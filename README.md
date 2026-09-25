//Valery Lot
//09/25/2026
//Challenge #5 Pet Adoption API
//What we did: We used CRUD operations, dependency injections to allow our classes to receive things they need without manually creating them, we used some LINQ methods to find a pet by it's ID, or return things in the form of a list. We also used .SaveChanges() to save the changes that EF Core has been tracking it all along in order to save it to the database. We also used HttpPatch in order to update some information without having to set a value for each key pair. And we did a soft delete for the pet section, so that if they needed to be brought back, we can change the IsDeleted value to false and it will show back up in our GetAll.
//Peer Review Name:Chris Estrada
//Review: 

Pets: I don't think the delete and adopt functions work as the assignment requests. Adopt returns a list of pets available for adoption but does not have a way to change "isAdopted". Delete was also not working for me but it could be a postman thing. all ids were returning 404 with a message. the functions are technically available through the update function since those can change "isAdopted" and "isDeleted" so i don't know if they need their own functions but the teachers probably want them (idk if it works it works).

Staff: Everything works and functions. I forgot to change the fields when updating salary and jop position, but because the patch wouldn't allow it the database didn't update it anyway. nothing you need to change just thought it was a cool feature.