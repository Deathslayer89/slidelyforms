# Slidely Forms

This project is a windows Forms app for managing submissions. It has a backend built with Express.js and TypeScript, and a frontend built with Visual Basic.

# Demo

[ loom(click here) ]()

## Table of Contents

- [Api Endpoints](#backend-endpoints)
- [Installation](#installation)


## Backend Endpoints

### 1. Ping

**Endpoint:** `GET /api/ping`

**Description:** A health check endpoint that always returns `true`.

**Response:**

```json
true
```

### 2.submit

**Endpoint:** `POST /api/submit`

**Description:** This endpoint is to save new submissions.

**body:**

```json
{
    'name':,
    'email':,
    'phone':,
    'github_link':,
    'stopwatch_time':
}
```

**respone:**

```json
{ "message": "Submission saved successfully!" }
```

### 3. read

**Endpoint:** `GET /api/read?index=0`

**Description:** This endpoint is to return the (index+1)th submission.

**Response:**

```json
{
    'name':,
    'email':,
    'phone':,
    'github_link':,
    'stopwatch_time':
}
```

### 4.delete

**Endpoint:** `DELETE /api/delete/:email`

**Description:** This endpoint deletes a particular submission.

**Response:**
```json
{ success: true }
```

### 5.update

**Endpoint:** `PUT /api/update/:email`

**body:**

```json
{
    'name':,
    'email':,
    'phone':,
    'github_link':,
    'stopwatch_time':
}
```
**Response:**

```json
true
```

### 5.search

**Endpoint:** `PUT /api/search`

**response:**

```json
{
    'name':,
    'email':,
    'phone':,
    'github_link':,
    'stopwatch_time':
}
```

## Installation

### Pre-requisites

- **Node.js**: [Download and install Node.js](https://nodejs.org/)
- **npm**: Node.js package manager (comes with Node.js)
- **.NET Framework**: [Download and install Visual Studio](https://visualstudio.microsoft.com/)
- **mongoDB** : create a mongoDB account and create a database and connect using URI.
### Backend Installation


***For the demonstration of the project no need to install backend in local machine just frontend Installation if fine . I have deployed the site at [https://slidely-backend.onrender.com](https://slidely-backend.onrender.com) and integrated in frontend code.***


 > **Clone the repository:**
   ```sh
   git clone https://github.com/Deathslayer89/slidelyforms.git
   cd slidely-backend
   npm run start
   ```

### Frontend Installation
> **open the folder frontend using visual studio and then run the project**
```sh
 cd frontend
```


# Demo

[ loom(click here) ]()