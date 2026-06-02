
body{
    background:#f3f4f6;
    color:#111827;
    font-family:-apple-system,BlinkMacSystemFont,"Segoe UI",sans-serif;
    max-width:900px;
    margin:0 auto;
    padding:0 24px;
    line-height:1.8;
}

header{
    display:flex;
    justify-content:space-between;
    align-items:center;
    padding:32px 0;
    border-bottom:1px solid #d1d5db;
}

.brand{
    display:flex;
    align-items:center;
    gap:12px;
    font-size:1.5rem;
    font-weight:600;
}

.avatar{
    width:36px;
    height:36px;
    border-radius:50%;
    object-fit:cover;
}

nav a{
    color:#4b5563;
    text-decoration:none;
    margin-left:24px;
}

nav a:hover{
    color:#111827;
}

.article{
    padding:36px 0;
    border-top:1px solid #e5e7eb;
}

.article a{
    color:#111827;
    text-decoration:none;
    font-size:2rem;
    font-weight:700;
}

.article a:hover{
    color:#2563eb;
}

.date{
    color:#6b7280;
    margin-top:12px;
}

.content{
    max-width:720px;
    margin:40px auto;
}

.content h1{
    font-size:2.25rem;
    line-height:1.25;
    margin-bottom:10px;
}

.content .date{
    margin-bottom:40px;
}

footer{
    border-top:1px solid #d1d5db;
    margin-top:60px;
    padding:24px 0;
    color:#6b7280;
}

@media(max-width:768px){

    header{
        flex-direction:column;
        gap:16px;
    }

    nav{
        margin-top:10px;
    }

    .article a{
        font-size:1.5rem;
    }

    .content h1{
        font-size:1.8rem;
    }
}
