# SongAPI
A simple API involving songs built in .NET created for a Code Assessment for Amplifund.

Features:
- CRUD functionality
- Dependency Injection
- Separation of concerns using repository architecture to decouple controllers (request handling), services (business logic), and repositories (data access)
- Error handling and logging
- User Authentication for data modifying APIs

Features I wanted to add but did not have time for in the allotted 4 hours:
- Unit Testing
- CI/CD in Azure

### How to authenticate yourself to test data modifying APIs
1. Notice that AddSong, UpdateSong, and DeleteSong require authentication in order to use them.
![image](https://github.com/user-attachments/assets/966611f2-7719-4562-9820-680922772b26)

2. In order to test these APIs, register an account, then login.
![image](https://github.com/user-attachments/assets/accd27cf-e5f6-4411-9558-82927e7851ad)

![image](https://github.com/user-attachments/assets/7dbda3be-f0fb-4e17-a808-7d7482790515)

3. After successfully logging in, identify the access token in the response body and copy it.
![image](https://github.com/user-attachments/assets/733a0095-9a36-4f90-81a9-390b498a4a7d)

4. Navigate back to the top of the page and click the Authorize button.
![image](https://github.com/user-attachments/assets/e8fb75cc-30cc-481e-83f4-88e650d2646a)

5. In the value textbox, enter "Bearer [access token]" and click Authorize.
![image](https://github.com/user-attachments/assets/9baa5ebf-2509-452d-92ca-ff9cc726f626)

6. After successfully logging in, you should now have access to the previously locked APIs, now indicated by a black lock. Feel free to use them now!
![image](https://github.com/user-attachments/assets/025c6c19-292b-4cf2-a40f-c801ebe1b249)



