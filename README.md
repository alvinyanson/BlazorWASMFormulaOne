### Installation
1. **Clone the repository:**
    ```bash
    git clone https://github.com/alvinyanson/BlazorWASMFormulaOne.git
    cd BlazorWASMFormulaOne
    ```

2. **Check the database connection:**
    - This project uses localdb connection, hence no configurations needed. It should look like the same below:
      ```bash
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=FormulaOneDb;Trusted_Connection=True;MultipleActiveResultSets=true"
      ```
    
    - Open Package Manage Console and run the following commands to apply migrations. (Make sure the selected project is FormulaOne.Server)
      ```bash
      update database
      ```

3. **Run the application:**

### Usage
- Access the application at `http://localhost:7003`
