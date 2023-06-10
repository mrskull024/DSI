import React, { Component } from 'react';
import { PowerBIEmbed } from 'powerbi-client-react';
import { models } from 'powerbi-client';

export class Reports extends Component {
    static displayName = Reports.name;

    render() {

        return (

            <PowerBIEmbed
                embedConfig={{
                    type: 'report',   // Supported types: report, dashboard, tile, visual, qna, paginated report and create
                    id: '310e86a0-e1d4-47d2-a7fa-08597d844570',
                    embedUrl: "https://app.powerbi.com/reportEmbed?reportId=310e86a0-e1d4-47d2-a7fa-08597d844570&config=eyJjbHVzdGVyVXJsIjoiaHR0cHM6Ly9XQUJJLVNPVVRILUNFTlRSQUwtVVMtQy1QUklNQVJZLXJlZGlyZWN0LmFuYWx5c2lzLndpbmRvd3MubmV0IiwiZW1iZWRGZWF0dXJlcyI6eyJtb2Rlcm5FbWJlZCI6dHJ1ZSwidXNhZ2VNZXRyaWNzVk5leHQiOnRydWV9fQ%3d%3dc",
                    accessToken: 'eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyIsImtpZCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyJ9.eyJhdWQiOiJodHRwczovL2FuYWx5c2lzLndpbmRvd3MubmV0L3Bvd2VyYmkvYXBpIiwiaXNzIjoiaHR0cHM6Ly9zdHMud2luZG93cy5uZXQvMzA2MTZjZmQtYmQ5NC00ZGQyLThjYTEtNGYyZDU5N2ZiZWNmLyIsImlhdCI6MTY4NjM2OTUzNCwibmJmIjoxNjg2MzY5NTM0LCJleHAiOjE2ODYzNzM3MDksImFjY3QiOjAsImFjciI6IjEiLCJhaW8iOiJBWVFBZS84VEFBQUEwWnhLeG5lTW56bVlnWWdudnh2NVRncjJLTFQyenR5RXNMVnBwOTYvMzdzZGxxVUdva1VqZ3diNzF3RGF2QU1tYUJJWDRjTEcxUFRGTGU5Y3orUit4L3ozNTQ0cWR4TEgxZjFZSE1kSDIycnVnVjZoMDIyUTE1MWlSbHR1VmtwbTNCbDVNcWF3aEgzMUd6dCtyZ2FpeXk5WjVoR3kxZ1JIbFd1bHljZjRCb1U9IiwiYW1yIjpbInB3ZCJdLCJhcHBpZCI6Ijg3MWMwMTBmLTVlNjEtNGZiMS04M2FjLTk4NjEwYTdlOTExMCIsImFwcGlkYWNyIjoiMCIsImZhbWlseV9uYW1lIjoiUGF6IiwiZ2l2ZW5fbmFtZSI6IkZhbm9yIiwiaXBhZGRyIjoiMTkwLjE0My4yNTIuMjEiLCJuYW1lIjoiRmFub3IgUGF6Iiwib2lkIjoiMTlkYjdjMWQtYmQ0Mi00MzUwLThhMzgtZWE1YTYzM2YwNWVlIiwicHVpZCI6IjEwMDMyMDAyQUZDNDFCRjYiLCJyaCI6IjAuQVVZQV9XeGhNSlM5MGsyTW9VOHRXWC0tendrQUFBQUFBQUFBd0FBQUFBQUFBQUNBQUdJLiIsInNjcCI6InVzZXJfaW1wZXJzb25hdGlvbiIsInN1YiI6ImNFSlhfVDdUSEhQakRHRmloUXRXVWd2NXE1d1h5NnhvNXM4TmlqX0lGaGciLCJ0aWQiOiIzMDYxNmNmZC1iZDk0LTRkZDItOGNhMS00ZjJkNTk3ZmJlY2YiLCJ1bmlxdWVfbmFtZSI6ImZhbm9ycGF6QGZwYXo5MTgub25taWNyb3NvZnQuY29tIiwidXBuIjoiZmFub3JwYXpAZnBhejkxOC5vbm1pY3Jvc29mdC5jb20iLCJ1dGkiOiJ5MTVXcEEtSHVFQ1AxSzE3aXh4bEFBIiwidmVyIjoiMS4wIiwid2lkcyI6WyI2MmU5MDM5NC02OWY1LTQyMzctOTE5MC0wMTIxNzcxNDVlMTAiLCJiNzlmYmY0ZC0zZWY5LTQ2ODktODE0My03NmIxOTRlODU1MDkiXSwieG1zX3BsIjoiZW4ifQ.dxuJzm4WUhbDN9NOl6kBTXUFvmmQ1wDwF_CoHEpomgpYdeaf0ckJUTj7XYmMRjFzuY4Yg38eI-7C7sYytEI05LV5MpdYwSMJhk-UTrmm-hutAIdo2rKbXTKr9yWNZoVTNpC6DVlD2FXE0mgUWiayGWOTnvn82SPYC2Jnpb0-6kPTQYT4CfJkwm35U59Tli0lYUk7L6HaFTJSCoiZY9PvvpNmP0T-zAxFLhn_1PjTU4l_F_deHELEVVLD0fTh51eql8qaOv-jB76km6yHagfsk9q9E4RTlbeESGXae7r_29-uJoHuktfJVf51oxSI2LTmoh-tghYIjw9TY4s0QeQMUg',
                    tokenType: models.TokenType.Embed, // Use models.TokenType.Aad for SaaS embed
                    settings: {
                        panes: {
                            filters: {
                                expanded: false,
                                visible: false
                            }
                        },
                        background: models.BackgroundType.Transparent,
                    }
                }}

                eventHandlers={
                    new Map([
                        ['loaded', function () { console.log('Report loaded'); }],
                        ['rendered', function () { console.log('Report rendered'); }],
                        ['error', function (event) { console.log(event.detail); }],
                        ['visualClicked', () => console.log('visual clicked')],
                        ['pageChanged', (event) => console.log(event)],
                    ])
                }

                cssClassName={"reportClass"}

                
            />

        )
    }


}