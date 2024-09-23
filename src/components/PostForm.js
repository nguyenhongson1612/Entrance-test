import React, { useState } from 'react';
import { useDispatch } from 'react-redux';
import { addPost } from '../redux/actions/postActions';

const PostForm = () => {
    const [userId, setUserId] = useState('');
    const [id, setId] = useState('');
    const [title, setTitle] = useState('');
    const [body, setBody] = useState('');
    const dispatch = useDispatch();

    const handleSubmit = (e) => {
        e.preventDefault();
        const newPost = { userId, id, title, body };
        dispatch(addPost(newPost));
        setUserId("");
        setId("");
        setTitle('');
        setBody('');
    };

    return (
        <form onSubmit={handleSubmit}>
            <input
                type="number"
                placeholder="UserId"
                value={userId}
                onChange={(e) => setUserId(e.target.value)}
                required
            />
            <input
                type="number"
                placeholder="Id"
                value={id}
                onChange={(e) => setId(e.target.value)}
                required
            />
            <input
                type="text"
                placeholder="Title"
                value={title}
                onChange={(e) => setTitle(e.target.value)}
                required
            />
            <input
                type="text"
                placeholder="Body"
                value={body}
                onChange={(e) => setBody(e.target.value)}
                required
            ></input>
            <button type="submit">Add Post</button>
        </form>
    );
};

export default PostForm;
