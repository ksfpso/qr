body {
          font-family: Arial, sans-serif;
            background-color: #f4f4f4;
             /* display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;*/
        }
        .container {
            grid-template-columns: repeat(2, 1fr);
            gap: 20px;
            max-width: 500px;
            width: 100%;

        }
        .header{
            display: block;
            width: 100%;
            height: 125px;
            max-width: 500px;
            min-width: 500px;
        }
        .logo{
            float: left;
            padding: 1%;
            width: 20%;
            background-color: #13bf7d;
        }
        .txt_head{
            float: left;
            padding: 5px 1%;
            text-transform: uppercase;
            font-weight: bold;
            color: #ffffff;
            width: 76%;
            background: #ff2727;
            height: 104px;
        }
        .txt_head span{
            display: block;
           padding: 30px 0;
        }
        .link-box {
            background-color: #ffffff;
            padding: 2px;
            text-align: center;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            transition: background-color 0.3s;
            border-bottom: 1px #ccc dotted;
            margin-bottom: 10px;
        }
        .link-box:hover {
            background-color: #4CAF50;
            color: white;
        }
        a {
            text-decoration: none;
            color: black;
            font-weight: bold;
            padding: 20px;
            display: block;
        }