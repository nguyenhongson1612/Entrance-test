import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchPosts } from '../redux/actions/postActions';

const PostList = () => {
    const dispatch = useDispatch();
    const posts = useSelector((state) => state.posts.items);

    useEffect(() => {
        dispatch(fetchPosts());
    }, [dispatch]);

    return (
        <div>
            <h2>Posts List:</h2>
            <ul>
                {posts.map((post) => (
                    <li key={post.id}>
                        <h3>UserId: {post.userId}</h3>
                        <h3>Id: {post.id}</h3>
                        <p>Title: {post.title}</p>
                        <p>Body: {post.body}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default PostList;
