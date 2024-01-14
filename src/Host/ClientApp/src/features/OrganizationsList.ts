import { localhostApi } from "../shared/localhostApi";

export interface UserLink {
    string: number;
    name: string;
}

export interface OrganizationLine {
    id: number;
    name: string;
    power: number;
    user: UserLink;
}

const extendedApiSlice = localhostApi.injectEndpoints({
    endpoints: builder => ({

        organization: builder.query<OrganizationLine[], undefined>({
            query: () => `organization/getOrganizations`
        })

    })
})

export const { useOrganizationQuery } = extendedApiSlice