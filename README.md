## URL Converter

#### Deploy, CI/CD
0. Deploy on IIS
1. Git push triggers Jenkins
2. Clone/Pull git
3. Restore project
4. Clean project
5. Build project/ Build test project
6. Run test
7. Publish

#### Future Enhancements
1. Implement a Web API to resolve/decrypt the short URLs, which may be optionally stored in a database
2. Interaction with Database
3. Cache the same short URLs, in case too many request interact with DB or decrypting at the same time
4. It could be a microservice if there's another app that needs the shortened URL or share link feature
5. Better logging would make debugging easier